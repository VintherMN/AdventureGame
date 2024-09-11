namespace AdventureGameClassLibrary
{
    public enum MonsterType
    {
        Orc,
        Ogre,
        Goblin,
        Troll
    }
    public class Monster : Creature
    {
        public MonsterType MonsterType { get; set; }
        public Monster(string name, Weapon weapon, int hitPoints, MonsterType monsterType)
            : base(name, weapon, hitPoints)
        {
            MonsterType = monsterType;
            Gold = random.Next(10) + 1;

        }

    }
}
