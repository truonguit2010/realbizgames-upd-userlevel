using UnityEngine;

public class UserLevelDTO
{
    private int _level;

    private string _levelName;

    public int Level { get => _level; set => _level = value; }
    public string LevelName { get => _levelName; set => _levelName = value; }

    public override string ToString()
    {
        return ToStringUtils.ToStringFor(this);
    }
}
