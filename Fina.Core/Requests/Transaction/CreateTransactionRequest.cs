using Fina.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transaction
{
    public class CreateTransactionRequest : Request
    {
        [Required(ErrorMessage = "Título inválido")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tipo inválido")]
        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

        [Required(ErrorMessage = "Valor inválido")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Categoria inválida")]
        public long CateogryId { get; set; }

        [Required(ErrorMessage = "Valor inválido")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}
