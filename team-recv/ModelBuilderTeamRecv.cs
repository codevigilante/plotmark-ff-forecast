
namespace plotmark.teamrecv
{
    public class ModelBuilderTeamRecv : Forecaster<TeamRecvModelInput, TeamRecvModelOutput>
    {
        private const string ModelPath = "plotmark.forecast.team_recv.MLModel.zip";

        public ModelBuilderTeamRecv()
            : base(ModelPath)
        {
        }
    }
}