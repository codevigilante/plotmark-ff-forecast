
namespace plotmark.teamrush
{
    public class ModelBuilderTeamRush : Forecaster<TeamRushModelInput, TeamRushModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.team_rush.MLModel.zip";

        public ModelBuilderTeamRush()
            : base(ModelPath)
        {
        }
    }
}