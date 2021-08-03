namespace NTwewyDb
{
    public class PinAttackElement
    {
        public sbyte Id { get; set; }
        public string ElementName { get; set; }
        public string ElementIcon { get; set; }
        public string MashupIcon { get; set; }
        public int SortIndex { get; set; }

        public PinAttackElement(sbyte id, string elementName, string elementIcon, string mashupIcon, int sortIndex)
        {
            Id = id;
            ElementName = elementName;
            ElementIcon = elementIcon;
            MashupIcon = mashupIcon;
            SortIndex = sortIndex;
        }
    }
}
