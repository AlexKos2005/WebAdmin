using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CwAuthorizationService.Dto
{

    /// <summary>
    /// Атрибут, для установки разрешенных ролей на методы Api
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthorizeEnumAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Атрибут для проверки ролей при обращении к методам API
        /// </summary>
        /// <param name="roles"></param>
        /// <exception cref="ArgumentException"></exception>
        public AuthorizeEnumAttribute(params object[] roles)
        {
            if (roles.Any(r => r.GetType().BaseType != typeof(Enum)))
                throw new ArgumentException("roles");

            this.Roles = string.Join(",", roles.Select(r => Enum.GetName(r.GetType(), r)));
        }
    }

    /// <summary>
    /// Роли пользователей
    /// </summary>
    public enum Roles
    {
        /// <summary>
        /// Не авторизован
        /// </summary>
        NoAuthorized,

        /// <summary>
        /// Базовые
        /// </summary>
        Base = 100,

        /// <summary>
        /// Базовые
        /// </summary>
        Application = 110,

        /// <summary>
        /// Поддержка
        /// </summary>
        Support = 200,

        /// <summary>
        /// Администратор
        /// </summary>
        Administrator = 300,

        /// <summary>
        /// Супер администратор
        /// </summary>
        SuperAdministrator = 400
    }
}
