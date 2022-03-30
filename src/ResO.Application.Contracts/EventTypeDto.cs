using System;
using Volo.Abp.Application.Dtos;

namespace ResO.Application.Contracts
{
    public class EventTypeRequestDto : PagedResultRequestDto
    {
        public int Id { get; private set; }
        public Guid? OrganizationUnitId { get; set; }
        public string EventTypeKey { get; set; }
    }

    public class EventTypeDto : ExtensibleEntityDto<Guid>
    {
        public string Key { get; set; }
        /// <summary>
        /// title in user language
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// maximum no. of participants for this event
        /// </summary>
        public int MaxParticipants { get; set; }
        /// <summary>
        /// minimum no. of participants for this event
        /// </summary>
        public int MinParticipants { get; set; }
        /// <summary>
        /// credit account
        /// </summary>
        public virtual string LedgerAccountNoCredit { get; set; }
        /// <summary>
        /// event cost for participants
        /// </summary>
        public virtual decimal Cost { get; set; }
        /// <summary>
        /// sets the color of the event type in the scheduler control
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// description (html) of cancellation terms
        /// </summary>
        public string CancellationTerms { get; set; }

    }
}
