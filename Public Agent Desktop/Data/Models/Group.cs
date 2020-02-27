using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PublicAgentDesktop.Data.Models
{
    /// <summary>
    ///     Представляет модель группы пользовательских привилегий.
    /// </summary>
    public class Group : BaseEntity
    {
        private int _groupId;
        private string _name;
        private string _description;

        private ICollection<User> _users;

        /// <summary>
        ///     Уникальный идентификатор группы
        ///     в информационной системе.
        /// </summary>
        [Key]
        [Required]
        public int GroupId 
        {
            get => this._groupId;
            set {
                this._groupId = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Имя группы.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Name 
        {
            get => this._name;
            set {
                this._name = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Подробное описание группы.
        /// </summary>
        [MaxLength]
        public string Description 
        {
            get => this._description == string.Empty ? "Описание не задано" : this._description;
            set {
                this._description = value;
                base.OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Пользователи, состоящие в данной группе привилегий.
        /// </summary>
        public ICollection<User> Users 
        {
            get => this._users;
            set {
                this._users = value;
                base.OnPropertyChanged();
            }
        }
    }
}
