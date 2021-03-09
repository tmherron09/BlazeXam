using System;
using System.Collections.Generic;
using System.Text;

namespace BlazeXam.Shared
{
    public interface IBlazeXamQuestion
    {
        BlazeXamQTypeEnum QType {get;}
        float AvailablePoints { get; set; }
        float PointsAchieved { get; set; }
        string QuestionText { get; set; }
        string QuestionSubText { get; set; }
        string QuestionHint { get; set; }

        bool IsAnswered { get; set; }


    }
}
