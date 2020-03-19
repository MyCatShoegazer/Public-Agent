using System.Security.Cryptography;
using System.Text;

namespace PublicAgentDesktop.Utility
{
    /// <summary>
    ///    Предоставляет пользовательские методы расширения для
    ///    базовых типов .NET Framework.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        ///     Получает MD5 сумму строки.
        /// </summary>
        /// <param name="source">Строка.</param>
        /// <returns>Возвращает MD5 сумму строки.</returns>
        public static string GetMD5(this string source)
        {
            var bytes = Encoding.UTF8.GetBytes(source);
            using (var provider = new MD5CryptoServiceProvider())
                bytes = provider.ComputeHash(bytes);

            return Encoding.UTF8.GetString(bytes);
        }
    }
}
