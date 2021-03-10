using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazeXam.Shared
{
    public class MultiSingle : IBlazeXamQuestion
    {
        private const BlazeXamQTypeEnum qType = BlazeXamQTypeEnum.MultipleChoiceSingle;

        [Key]
        public int Id { get; set; }

        public BlazeXamQTypeEnum QType
        {
            get
            {
                return qType;
            }
        }

        [Required]
        public float AvailablePoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float PointsAchieved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public string QuestionText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string QuestionSubText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string QuestionHint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsAnswered { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MultiSingle()
        {

        }
        public MultiSingle(string questionText, float availablePoints)
        {
            QuestionText = questionText;
            AvailablePoints = availablePoints;
        }
    }
}
