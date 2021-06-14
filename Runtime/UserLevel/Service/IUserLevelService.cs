using UnityEngine;

public interface IUserLevelService : IService
{
    UserLevelDTO Get();

    void NextLevel();
}
