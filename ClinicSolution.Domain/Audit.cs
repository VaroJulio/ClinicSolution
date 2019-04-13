using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain
{
    public abstract class Audit
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set => _id = default(Guid) != value ? value : NewGuid();
        }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Active { get; set; }

        protected Audit()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
            Active = true;
        }

        protected Guid NewGuid()
        {
            return default(Guid) != _id ? _id : Guid.NewGuid();
        }
    }
}
