namespace NTwewyDb
{
    public class ShopGood
    {
        public ushort Id { get; set; }
        public sbyte Shop { get; set; }
        public ushort Item { get; set; }
        public byte[] ItemCount { get; set; }
        public int Price { get; set; }
        public sbyte Exchange { get; set; }
        public sbyte ReleaseVip { get; set; }
        public sbyte ReleaseDay { get; set; }
        public sbyte ReleaseRegular { get; set; }
        public byte ReleaseSkill { get; set; }
        public int SortIndex { get; set; }
        public int SaveIndex { get; set; }
        public string GoodsName { get; set; }
        public int ReleaseParam { get; set; }

        public ShopGood(ushort id, sbyte shop, ushort item, byte[] itemCount, int price, sbyte exchange, sbyte releaseVip, sbyte releaseDay, sbyte releaseRegular, byte releaseSkill, int sortIndex, int saveIndex, string goodsName, int releaseParam)
        {
            Id = id;
            Shop = shop;
            Item = item;
            ItemCount = itemCount;
            Price = price;
            Exchange = exchange;
            ReleaseVip = releaseVip;
            ReleaseDay = releaseDay;
            ReleaseRegular = releaseRegular;
            ReleaseSkill = releaseSkill;
            SortIndex = sortIndex;
            SaveIndex = saveIndex;
            GoodsName = goodsName;
            ReleaseParam = releaseParam;
        }
    }
}
