public class BattleChara
{
    public CharaData Data { get; private set; }

    public float Hp { get; private set; }
    public float BaseAttack { get; private set; }

    public BattleChara(CharaData data)
    {
        this.Data = data;
        Hp = data.hp;
        BaseAttack = data.attack;
    }
}
