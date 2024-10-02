namespace EquipmentManager_Assignment1.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public EquipmentType Type { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
