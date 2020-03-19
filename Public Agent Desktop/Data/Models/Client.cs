using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAgentDesktop.Data.Models
{
    public class Client : BaseEntity
    {
        private int _clientId;
        private string _email;
        private string _phone;
        private string _lastName;
        private string _firstName;
        private string _livingAddres;
        private string _zipCode;

        private User _user;

        /// <summary>
        ///     Уникальный идентификатор клиента
        ///     в информационной системе.
        /// </summary>
        [Key]
        [Required]
        public int ClientId
        {
            get => this._clientId;
            set
            {
                this._clientId = value;
                base.OnPropertyChanged();
            }
        }
        /// <summary>
        ///     Адрес электронной почты клиента.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email address must be not empty!")]
        [EmailAddress]
        public string Email
        {
            get => this._email;
            set
            {
                this._email = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Контактный номер клиента.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone number must be not empty!")]
        [Phone]
        public string Phone
        {
            get => this._phone;
            set
            {
                this._phone = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Фамилия клиента.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name must be not empty!")]
        [MaxLength(20)]
        public string LastName
        {
            get => this._lastName;
            set
            {
                this._lastName = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Имя клиента.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name must be not empty!")]
        [MaxLength(20)]
        public string FirstName
        {
            get => this._firstName;
            set
            {
                this._firstName = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Адрес проживания клиента.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Living addres must be not empty!")]
        [MaxLength(120)]
        public string LivingAddres
        {
            get => this._livingAddres;
            set
            {
                this._livingAddres = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Почтовый индекс.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Zip code must be not empty!")]
        [MaxLength(6)]
        public string ZipCode
        {
            get => this._zipCode;
            set
            {
                this._zipCode = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Агент
        /// </summary>
        private User User
        {
            get => this._user;
            set
            {
                this._user = value;
                base.OnPropertyChanged();
            }
        }
    }
}
