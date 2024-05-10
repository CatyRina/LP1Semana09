using System;

public enum PlayerClass
{
    Warrior,
    Mage,
    Rogue,
    Ranger
}

public class Player
{
    public string Name { get; }
    public int Level { get; }
    public PlayerClass Class { get; }

    public Player(string name, int level, PlayerClass playerClass)
    {
        Name = name;
        Level = level;
        Class = playerClass;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + Level.GetHashCode();
            hash = hash * 23 + Class.GetHashCode();
            return hash;
        }
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Player other = (Player)obj;
        return Name == other.Name && Level == other.Level && Class == other.Class;
    }
}



