using System;

namespace NTwewyDb
{
    public class Shop : IEquatable<Shop>
    {
        public sbyte Id { get; set; }
        public string Name { get; set; }
        public string ShopCategory { get; set; }
        public int ShopType { get; set; }
        public byte Brand { get; set; }
        public ushort SymbolItem { get; set; }
        public int SkillId { get; set; }
        public int StaffId { get; set; }
        public ushort Bgm { get; set; }
        public string Background { get; set; }
        public bool ChangeBackground { get; set; }
        public int SaveIndex { get; set; }
        public ushort[] RegularBuy { get; set; }
        public ushort[] RegularDay { get; set; }
        public ushort[] RegularVip { get; set; }
        public ushort[] ShopTalk { get; set; }

        public Shop(sbyte id, string name, string shopCategory, int shopType, byte brand, ushort symbolItem, int skillId, int staffId, ushort bgm, string background, bool changeBackground, int saveIndex, ushort[] regularBuy, ushort[] regularDay, ushort[] regularVip, ushort[] shopTalk)
        {
            Id = id;
            Name = name;
            ShopCategory = shopCategory;
            ShopType = shopType;
            Brand = brand;
            SymbolItem = symbolItem;
            SkillId = skillId;
            StaffId = staffId;
            Bgm = bgm;
            Background = background;
            ChangeBackground = changeBackground;
            SaveIndex = saveIndex;
            RegularBuy = regularBuy;
            RegularDay = regularDay;
            RegularVip = regularVip;
            ShopTalk = shopTalk;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Shop);
        }

        public bool Equals(Shop other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
