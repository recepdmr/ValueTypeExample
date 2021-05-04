using System;

namespace ValueTypeExample.Entities
{
    class Ticket
    {
        public Guid Id { get; set; }
        public string PnrNo { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public PnrDetail PnrDetail { get; set; }
    }
}
