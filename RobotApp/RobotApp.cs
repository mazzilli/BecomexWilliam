using Models;
namespace RobotApp
{
    public class RobotApp : IRobotApp
    {
        public Robot Robot { get; set; } = new();

        public RobotApp()
        {

        }

        public void MoveElbow(bool left, Elbow newState)
        {
            if (left)
            {
                if (CheckValidMove((int)Robot.Arms.LeftElbow, (int)newState)) Robot.Arms.LeftElbow = newState;
            }
            else
                if (CheckValidMove((int)Robot.Arms.RightElbow, (int)newState)) Robot.Arms.RightElbow = newState;
        }

        public void MoveFist(bool left, Fist newState)
        {
            if (left)
            {
                if (Robot.Arms.LeftElbow == Elbow.FortementeContraído
                    && CheckValidMove((int)Robot.Arms.LeftFist, (int)newState)) Robot.Arms.LeftFist = newState;
            }
            else
            {
                if (Robot.Arms.RightElbow == Elbow.FortementeContraído
                    && CheckValidMove((int)Robot.Arms.RightFist, (int)newState)) Robot.Arms.RightFist = newState;
            }
        }

        public void MoveHeadTilt(Tilt newTilt)
        {
            if (CheckValidMove((int)Robot.Head.Tilt, (int)newTilt))
                Robot.Head.Tilt = newTilt;
        }

        public void MoveHeadRotation(Rotation newRotation)
        {
            if (Robot.Head.Tilt != Tilt.ParaBaixo
                && CheckValidMove((int)Robot.Head.Rotation, (int)newRotation))
                Robot.Head.Rotation = newRotation;
        }

        private static bool CheckValidMove(int a, int b)
        {
            return Math.Abs(a - b) == 1;
        }
    }
}