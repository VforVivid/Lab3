namespace QueryBuilderStarter
{
    internal class Pokemon : IClassModel
    {
        public int Id {get;set;} 
        public int DexNumber {get;set;}
        public string Name {get;set;} = string.Empty;
        public string Form {get;set;} = string.Empty;
        public string Type1 {get;set;} = string.Empty;
        public string Type2 {get;set;} = string.Empty;
        public int Total {get;set;}
        public int HP {get;set;}
        public int Attack {get;set;}
        public int Defense {get;set;}
        public int SpecialAttack {get;set;}
        public int SpecialDefense {get;set;}
        public int Speed {get;set;}
        public int Generation {get;set;}


        public Pokemon(){

        }

        public Pokemon(string name, string form, string type1, string type2, int total, int hp, int attack, int defense, int specialattack, int specialdefense, int speed, int generation)
        {
            Name = name;
            Form = form;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            HP = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialattack;
            SpecialDefense = specialdefense;
            Speed = speed;
            Generation = generation;
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Name :  {Name}";
            msg += $"Form: {Form}";
            msg += $"Type1: {Type1}";
            msg += $"Type2: {Type2}";
            msg += $"Total: {Total}";
            msg += $"HP: {HP}";
            msg += $"Attack: {Attack}";
            msg += $"Defense: {Defense}";
            msg += $"SpecialAttack: {SpecialAttack}";
            msg += $"SpecialDefense: {SpecialDefense}";
            msg += $"Speed: {Speed}";
            msg += $"Generation: {Generation}";
            return msg;
        }
    }
}
