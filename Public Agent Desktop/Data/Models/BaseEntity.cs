using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PublicAgentDesktop.Data.Models
{
    /// <summary>
    ///     Предоставляет базовый функционал для всех моделей сущностей.
    /// </summary>
    public abstract class BaseEntity : INotifyPropertyChanged
    {
        /// <summary>
        ///     Происходит, при изменении свойства модели.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Вызывает <see cref="System.ComponentModel.PropertyChangedEventHandler"/>
        ///     и передаёт имя изменённого свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменённого свойства.</param>
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            var args = new PropertyChangedEventArgs(propertyName);
            this.PropertyChanged?.Invoke(this, args);
        }
    }
}
