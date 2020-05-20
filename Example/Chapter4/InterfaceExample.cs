class Knight : ISword, IShield
{
    public string Damage { get; set; }
    public string DefensivePower { get; set; }

    public void Attack()
    {
        
    }

    public void Defend()
    {
        
    }
}

interface ISword
{
    string Damage { get; set; }
    void Attack();
}

interface IShield
{
    string DefensivePower { get; set; }
    void Defend();
}