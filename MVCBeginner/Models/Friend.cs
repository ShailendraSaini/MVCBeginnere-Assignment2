using System.ComponentModel.DataAnnotations;
using Resources = MVCBeginner.Properties.Resources;
namespace MVCBeginner.Models
{
    public class Friend
    {
        [Required]
        [Display(Name = nameof(Resources.FriendID), ResourceType = typeof(Resources))]
        public int FriendID { get; set; }

        [StringLength(50)]
        [Display(Name = nameof(Resources.FriendName), ResourceType = typeof(Resources))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(Resources.FieldRequired),
ErrorMessageResourceType = typeof(Resources))]
        public string FriendName { get; set; }

        [StringLength(25)]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(Resources.FieldRequired),
ErrorMessageResourceType = typeof(Resources))]
        public string Place { get; set; }
    }
}