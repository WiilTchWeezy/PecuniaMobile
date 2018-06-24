using Pecunia.Data.Enums;
using Realms;

namespace Pecunia.Data.DataObjects
{
    public class Movement : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Observation { get; set; }
        public int? CategoryId { get; set; }
        public double Value { get; set; }
        public MovementEnum MovementType { get; set; }
    }
}
