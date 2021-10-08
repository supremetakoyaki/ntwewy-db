using System;
using System.Collections.Generic;

namespace NTwewyDb
{
    public class Brand : IEquatable<Brand>
    {
        public byte Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Sprite
        {
            get;
            set;
        }

        public int SaveIndex
        {
            get;
            set;
        }

        public ushort[] RankPoints
        {
            get;
            set;
        }

        public Brand(byte id, string name, string sprite, int saveIndex, ushort[] rankPoints)
        {
            Id = id;
            Name = name;
            Sprite = sprite;
            SaveIndex = saveIndex;
            RankPoints = rankPoints;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Brand);
        }

        public bool Equals(Brand other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public static bool operator ==(Brand left, Brand right)
        {
            return EqualityComparer<Brand>.Default.Equals(left, right);
        }

        public static bool operator !=(Brand left, Brand right)
        {
            return !(left == right);
        }
    }
}
