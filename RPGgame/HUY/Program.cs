using RPGworld1;

int a = 5;
if (a > 5)
{
    Console.WriteLine("Afa");
}else if (a < 5)
{
    Console.WriteLine("dfg");
}
BackPack backPack = new(5);
backPack.Looting(1);
backPack.Looting(1);

Hero hero = new("Hero", 10, 100);
Enemy enemy = new("Дракон", 11, 150, 15);
BattleArena arena = new(enemy, hero, backPack);
arena.Battle();
arena.Battle();