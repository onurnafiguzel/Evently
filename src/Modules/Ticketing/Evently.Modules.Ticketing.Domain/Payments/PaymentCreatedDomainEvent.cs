using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evently.Common.Domain;

namespace Evently.Modules.Ticketing.Domain.Payments;
public sealed class PaymentCreatedDomainEvent(Guid paymentId) : DomainEvent
{
    public Guid PaymentId { get; init; } = paymentId;
}
