
namespace UnitTestRobot
{
    [TestClass]
    public class RobotTests
    {
        [TestMethod]
        public void CheckInitalState()
        {
            var r = new RobotApp.RobotApp();

            Assert.AreEqual(r.Robot.Arms.LeftElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.LeftFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Head.Rotation, Models.Rotation.Repouso);
            Assert.AreEqual(r.Robot.Head.Tilt, Models.Tilt.Repouso);
        }

        [TestMethod]
        public void MoveElbowLeft()
        {
            var r = new RobotApp.RobotApp();

            r.MoveElbow(true, Models.Elbow.LevementeContra�do);

            Assert.AreEqual(r.Robot.Arms.LeftElbow, Models.Elbow.LevementeContra�do);
            Assert.AreEqual(r.Robot.Arms.RightElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.LeftFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Head.Rotation, Models.Rotation.Repouso);
            Assert.AreEqual(r.Robot.Head.Tilt, Models.Tilt.Repouso);
        }

        [TestMethod]
        public void MoveElbowLeft2x()
        {
            var r = new RobotApp.RobotApp();

            r.MoveElbow(true, Models.Elbow.LevementeContra�do);
            r.MoveElbow(true, Models.Elbow.Contraido);
            r.MoveElbow(true, Models.Elbow.FortementeContra�do);

            Assert.AreEqual(r.Robot.Arms.LeftElbow, Models.Elbow.FortementeContra�do);
            Assert.AreEqual(r.Robot.Arms.RightElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.LeftFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Head.Rotation, Models.Rotation.Repouso);
            Assert.AreEqual(r.Robot.Head.Tilt, Models.Tilt.Repouso);
        }

        [TestMethod]
        public void MoveElbowLeftInvalidMoviment()
        {
            var r = new RobotApp.RobotApp();
                        
            r.MoveElbow(true, Models.Elbow.FortementeContra�do);

            Assert.AreEqual(r.Robot.Arms.LeftElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.LeftFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Head.Rotation, Models.Rotation.Repouso);
            Assert.AreEqual(r.Robot.Head.Tilt, Models.Tilt.Repouso);
        }

        [TestMethod]
        public void MoveFist()
        {
            var r = new RobotApp.RobotApp();

            r.MoveElbow(true, Models.Elbow.LevementeContra�do);
            r.MoveElbow(true, Models.Elbow.Contraido);
            r.MoveElbow(true, Models.Elbow.FortementeContra�do);
            r.MoveFist(true, Models.Fist.P45);

            Assert.AreEqual(r.Robot.Arms.LeftElbow, Models.Elbow.FortementeContra�do);
            Assert.AreEqual(r.Robot.Arms.RightElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.LeftFist, Models.Fist.P45);
            Assert.AreEqual(r.Robot.Arms.RightFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Head.Rotation, Models.Rotation.Repouso);
            Assert.AreEqual(r.Robot.Head.Tilt, Models.Tilt.Repouso);
        }

        [TestMethod]
        public void MoveFistInvalidMove()
        {
            var r = new RobotApp.RobotApp();

            r.MoveFist(true, Models.Fist.P90);

            Assert.AreEqual(r.Robot.Arms.LeftElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.LeftFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Head.Rotation, Models.Rotation.Repouso);
            Assert.AreEqual(r.Robot.Head.Tilt, Models.Tilt.Repouso);
        }

        [TestMethod]
        public void MoveHeadRotation()
        {
            var r = new RobotApp.RobotApp();

            r.MoveHeadRotation(Models.Rotation.L45);

            Assert.AreEqual(r.Robot.Arms.LeftElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.LeftFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Head.Rotation, Models.Rotation.L45);
            Assert.AreEqual(r.Robot.Head.Tilt, Models.Tilt.Repouso);
        }

        [TestMethod]
        public void MoveHeadRotationInvalid()
        {
            var r = new RobotApp.RobotApp();
            r.MoveHeadTilt(Models.Tilt.ParaBaixo);
            r.MoveHeadRotation(Models.Rotation.L45);

            Assert.AreEqual(r.Robot.Arms.LeftElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightElbow, Models.Elbow.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.LeftFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Arms.RightFist, Models.Fist.EmRepouso);
            Assert.AreEqual(r.Robot.Head.Rotation, Models.Rotation.Repouso);
            Assert.AreEqual(r.Robot.Head.Tilt, Models.Tilt.ParaBaixo);
        }
    }
}