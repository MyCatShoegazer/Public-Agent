using System;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using PublicAgentDesktop.Data;
using PublicAgentDesktop.Utility;

namespace PublicAgentDesktop.Ui.Dialogs
{
    public partial class SignInDialog : Form
    {
        public SignInDialog()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (new SignUpDialog().ShowDialog(this) == DialogResult.OK)
            {
                //do something else
            }
        }

        /// <summary>
        ///     Происходит, при нажатии на кнопку входа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void signInButton_Click(object sender, EventArgs e)
        {
            /*
             * Создаём экземпляр контекста базы данных.
             */
            using (var context = new PublicAgentDbContext())
            {
                /*
                 * Зашифруем введённый пароль перед поиском.
                 */
                var password = this.passwordTextBox.Text;

                /*
                 * Ищем пользователя с заданным сочетанием
                 * логина и пароля.
                 */
                var query = from u in context.Users
                        join g in context.Groups on u.Group equals g
                        where u.Login == this.loginTextBox.Text && u.Password == password
                        select new { u.Login, u.Password, Group = g };

                /*
                 * Получаем результаты запроса.
                 */
                var user = query.FirstOrDefault();

                /*
                 * Если такой пользователь найден, то утверждаем
                 * его идентификацию в потоке приложения.
                 */
                if (user != null)
                {
                    var identity = new GenericIdentity(user.Login);
                    var principal = new GenericPrincipal(identity, new string[] { user.Group.Name });
                    Thread.CurrentPrincipal = principal;

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    /*
                     * В случае ошибки авторизации выводим
                     * соответствующие сообщение.
                     */
                    MessageBox.Show(
                        "User with current login and password not found. Please try again.",
                        "Authorization error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
