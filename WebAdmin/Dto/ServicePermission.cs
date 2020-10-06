using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CwAuthorizationService.Dto
{
    
    /*[Flags]
    public enum ServicePermissions
    {
        SmsNotifications = 1,
        PhotoEmailReporter = 2,
        CardsSync = 4
    }

    public class ServicePermission
    {
        public bool IsPermitCardsSync { get; set; }
        public bool IsPermitSmsNotifications { get; set; }
        public bool IsPermitPhotoEmailReporter { get; set; }

        public ServicePermission FromFlags(ServicePermissions flags)
        {
            return new ServicePermission
            {
                IsPermitSmsNotifications = flags.HasFlag(ServicePermissions.SmsNotifications),
                IsPermitPhotoEmailReporter = flags.HasFlag(ServicePermissions.PhotoEmailReporter),
                IsPermitCardsSync = flags.HasFlag(ServicePermissions.CardsSync)
            };
        }

        public ServicePermissions ToFlags()
        {
            ServicePermissions permissions = default;
            if (IsPermitCardsSync)
            {
                permissions |= ServicePermissions.CardsSync;
            }
            if (IsPermitPhotoEmailReporter)
            {
                permissions |= ServicePermissions.PhotoEmailReporter;
            }
            if (IsPermitSmsNotifications)
            {
                permissions |= ServicePermissions.SmsNotifications;
            }

            return permissions;
        }}*/
    
}
