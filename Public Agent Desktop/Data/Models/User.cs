using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        private byte[] _photo;

        private Group _group;
        private ICollection<Client> _clients;

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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Login must be not empty!")]
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password must be not empty!")]
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email address must be not empty!")]
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone number must be not empty!")]
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name must be not empty!")]
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name must be not empty!")]
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
        public byte[] Photo 
        {
            get => this._photo == null ? new byte[0] : this._photo;
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

        /// <summary>
        ///     Список клиентов
        /// </summary>
        public ICollection<Client> Clients
        {
            get => this._clients;
            set
            {
                this._clients = value;
                base.OnPropertyChanged();
            }
        }
    }
}
