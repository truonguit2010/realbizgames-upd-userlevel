using System.Collections;

public class UserLevelEntityConvertor
{
    public static UserLevelEntity From(UserLevelDTO dto) {
        UserLevelEntity entity = new UserLevelEntity();
        entity.level = dto.Level;

        return entity;
    }
}
