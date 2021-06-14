using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserLevelDTOConvertor
{
    public static UserLevelDTO From(UserLevelEntity entity) {
        UserLevelDTO dto = new UserLevelDTO();

        dto.Level = entity.level;
        dto.LevelName = entity.level.ToString();

        return dto;
    }
}
