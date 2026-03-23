using UnityEngine;

public class BattleCharaFactory
{
    private readonly CharaDatabase database;

    public BattleCharaFactory(CharaDatabase database)
    {
        this.database = database;
    }

    public BattleChara CreateChara(int id)
    {
        var data = database.GetCharaData(id);
        var chara = new BattleChara(data);
        return chara;
    }
}
