using System.Collections;
using System.Collections.Generic;

public class UserLevelPlayerPrefRepository : GenericPlayerPrefRepository<UserLevelEntity>
{
    public const string KEY_IN_PLAYER_PREF = "UserLevelData";
    public UserLevelPlayerPrefRepository () : base(KEY_IN_PLAYER_PREF) {

    } 
}
