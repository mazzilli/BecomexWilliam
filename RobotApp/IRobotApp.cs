using Models;

namespace RobotApp
{
    public interface IRobotApp
    {        
        Robot Robot { get; }

        void MoveElbow(bool left, Elbow newState);
        void MoveFist(bool left, Fist newState);
        void MoveHeadRotation(Rotation newRotation);
        void MoveHeadTilt(Tilt newTilt);
    }
}