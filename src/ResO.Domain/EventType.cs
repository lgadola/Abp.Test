using System;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;

namespace ResO.Domain
{
    public class EventType : AuditedEntity<Guid>, IHasExtraProperties, IMultiTenant
    {
        public EventType ()
        {
            Id = Guid.NewGuid();
            ExtraProperties = new ExtraPropertyDictionary();
        }
        public Guid? TenantId { get; set; }
        /// <summary>
        /// owner OrganizationUnit of the Eventtype - used for billing purposes
        /// </summary>
        public string Key { get; set; }
        public virtual int MaxParticipants { get; set; }
        public virtual int MinParticipants { get; set; }
        /// <summary>
        /// event cost for participants
        /// </summary>
        public virtual decimal Cost { get; set; }
        /// <summary>
        /// sets the color of the event type in the scheduler control
        /// </summary>
        public virtual string Color { get; set; }
        /// <summary>
        /// subscription types that can book this event type
        /// </summary>
        // public virtual ICollection<EventTypesBookableBySubscription> BookingSubscriptionTypes { get; set; }
        /// <summary>
        /// credit account
        /// </summary>
        public virtual string LedgerAccountNoCredit { get; set; }
        public virtual string Title { get; set; }
        /// <summary>
        /// description text for cancellation terms
        /// </summary>
        public virtual string CancellationTerms { get; set; }

        public ExtraPropertyDictionary ExtraProperties { get; set; }
    }
}
