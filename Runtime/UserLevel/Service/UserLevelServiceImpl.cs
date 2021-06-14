using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserLevelServiceImpl : IUserLevelService
{

    private IPlayerPrefRepository<UserLevelEntity> repository = new UserLevelPlayerPrefRepository();

    public UserLevelDTO Get()
    {
        UserLevelEntity entity = repository.GetT();
        if (entity == null) {
            UserLevelDTO dto = new UserLevelDTO();
            dto.Level = 1;
            dto.LevelName = "1";
            return dto;
        } else {
            return UserLevelDTOConvertor.From(entity);
        }
    }

    public void init()
    {
        repository.init();
    }

    public void lazyInit()
    {
        repository.lazyInit();
    }

    public void NextLevel()
    {
        UserLevelEntity entity = repository.GetT();
        if (entity == null) {
            entity = new UserLevelEntity();
            entity.level = 1;
        }
        entity.level++;

        repository.Save(entity);
    }

    public void refresh()
    {
        repository.refresh();
    }
}
