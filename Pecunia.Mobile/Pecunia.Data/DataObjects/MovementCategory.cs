using Realms;

namespace Pecunia.Data.DataObjects
{
    public class MovementCategory : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
