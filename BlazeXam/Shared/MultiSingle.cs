using System;
using System.Collections.Generic;
using System.Text;

namespace BlazeXam.Shared
{
    public class MultiSingle : IBlazeXamQuestion
    {
        private const BlazeXamQTypeEnum qType = BlazeXamQTypeEnum.MultipleChoiceSingle;

        public BlazeXamQTypeEnum QType
        {
            get
            {
                return qType;
            }
        }

        public float AvailablePoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float PointsAchieved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string QuestionText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string QuestionSubText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string QuestionHint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsAnswered { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
