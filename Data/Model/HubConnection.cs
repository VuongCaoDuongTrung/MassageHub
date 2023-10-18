
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BE_Shop.Models
{
    public partial class HubConnection
    {
        [Key]
        public Guid Id { get; set; } = Guid.Empty;
        [Required] public string UserName { get; set; } = string.Empty;
        [Required] public string ConnectionId { get; set; } = string.Empty;

    }
}
