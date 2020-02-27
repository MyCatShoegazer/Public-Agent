using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PublicAgentDesktop.Data.Models
{
    /// <summary>
    ///     Представляет модель пользователя
    ///     информационной системы.
    /// </summary>
    public class User : BaseEntity
    {
        private int _userId;
        private string _login;
        private string _password;
        private string _email;
        private string _phone;
        private string _lastName;
        private string _firstName;
        private Bitmap _photo;

        private Group _group;

        /// <summary>
        ///     Уникальный идентификатор пользователя
        ///     в информационной системе.
        /// </summary>
        [Key]
        [Required]
        public int UserId 
        {
            get => this._userId;
            set {
                this._userId = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Логин пользователя, используемый для
        ///     авторизации в информационной системе.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Login 
        {
            get => this._login;
            set {
                this._login = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Пароль пользователя, используемый для
        ///     авторизации в информационной системе.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Password 
        {
            get => this._password;
            set {
                this._password = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Адрес электронной почты пользователя.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email 
        {
            get => this._email;
            set {
                this._email = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Контактный номер телефона.
        /// </summary>
        [Required]
        [Phone]
        public string Phone 
        {
            get => this._phone;
            set {
                this._phone = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Фамилия пользователя.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string LastName 
        {
            get => this._lastName;
            set {
                this._lastName = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Имя пользователя.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string FirstName 
        {
            get => this._firstName;
            set {
                this._firstName = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Фотография пользователя.
        /// </summary>
        public Bitmap Photo 
        {
            get => this._photo == null ? new Bitmap(1, 1) : this._photo;
            set {
                this._photo = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Группа привилегий пользователя.
        /// </summary>
        public Group Group {
            get => this._group;
            set {
                this._group = value;
                base.OnPropertyChanged();
            }
        }
    }
}
