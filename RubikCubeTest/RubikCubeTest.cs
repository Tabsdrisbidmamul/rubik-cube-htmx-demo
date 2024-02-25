using RubikCube.Services;

namespace RubikCubeTest
{
    public class RubikCubeTests
    {
        private IRubikCube _rubikCubeService;

        [SetUp]
        public void Setup()
        {
            _rubikCubeService = new RubikCubeService();
        }

        [Test]
        public void Rotate_Forward_90_Clockwise_Successfully()
        {
            _rubikCubeService.RotateFront90Clockwise();

            char[][] modifiedFaces = [
                ['G', 'G', 'G', 'G', 'G', 'G', 'G', 'G', 'G'],
                ['O', 'O', 'Y', 'O', 'O', 'Y', 'O', 'O', 'Y'],
                ['R', 'R', 'R', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y'],
                ['W', 'R', 'R', 'W', 'R', 'R', 'W', 'R', 'R'],
                ['B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B'],
                ['W', 'W', 'W', 'W', 'W', 'W', 'O', 'O', 'O']
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Forward_90_Anti_Clockwise_Successfully() 
        {
            _rubikCubeService.RotateFront90AntiClockwise();

            char[][] modifiedFaces = [
                ['G', 'G', 'G', 'G', 'G', 'G', 'G', 'G', 'G'],
                ['O', 'O', 'W', 'O', 'O', 'W', 'O', 'O', 'W'],
                ['O', 'O', 'O', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y'],
                ['Y', 'R', 'R', 'Y', 'R', 'R', 'Y', 'R', 'R'],
                ['B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B'],
                ['W', 'W', 'W', 'W', 'W', 'W', 'R', 'R', 'R']
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Right_90_Clockwise_Successfully() 
        {
            _rubikCubeService.RotateRight90Clockwise();

            char[][] modifiedFaces = [
                ['G', 'G', 'Y', 'G', 'G', 'Y', 'G', 'G', 'Y'],
                ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
                ['Y', 'Y', 'B', 'Y', 'Y', 'B', 'Y', 'Y', 'B'],
                ['R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R'],
                ['W', 'B', 'B', 'W', 'B', 'B', 'W', 'B', 'B'],
                ['W', 'W', 'G', 'W', 'W', 'G', 'W', 'W', 'G']
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Right_90_Anti_Clockwise_Successfully()
        {
            _rubikCubeService.RotateRight90AntiClockwise();

            char[][] modifiedFaces = [
                ['G', 'G', 'W', 'G', 'G', 'W', 'G', 'G', 'W'],
                ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
                ['Y', 'Y', 'G', 'Y', 'Y', 'G', 'Y', 'Y', 'G'],
                ['R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R'],
                ['Y', 'B', 'B', 'Y', 'B', 'B', 'Y', 'B', 'B'],
                ['W', 'W', 'B', 'W', 'W', 'B', 'W', 'W', 'B'],
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Up_90_Clockwise_Successfully()
        { 
            _rubikCubeService.RotateUp90Clockwise();
            
            char[][] modifiedFaces = [
                ['R', 'R', 'R', 'G', 'G', 'G', 'G', 'G', 'G'],
                ['G', 'G', 'G', 'O', 'O', 'O', 'O', 'O', 'O'],
                ['Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y'],
                ['B', 'B', 'B', 'R', 'R', 'R', 'R', 'R', 'R'],
                ['O', 'O', 'O', 'B', 'B', 'B', 'B', 'B', 'B'],
                ['W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W'],
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Roate_Up_90_Anti_Clockwise_Successfully()
        {
            _rubikCubeService.RotateUp90AntiClockwise();

            char[][] modifiedFaces = [
                ['O', 'O', 'O', 'G', 'G', 'G', 'G', 'G', 'G'],
                ['B', 'B', 'B', 'O', 'O', 'O', 'O', 'O', 'O'],
                ['Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y'],
                ['G', 'G', 'G', 'R', 'R', 'R', 'R', 'R', 'R'],
                ['R', 'R', 'R', 'B', 'B', 'B', 'B', 'B', 'B'],
                ['W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W'],
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Back_90_Clockwise_Succesfully()
        {
            _rubikCubeService.RotateBack90Clockwise();

            char[][] modifiedFaces = [
                ['G', 'G', 'G', 'G', 'G', 'G', 'G', 'G', 'G'],
                ['W', 'O', 'O', 'W', 'O', 'O', 'W', 'O', 'O'],
                ['Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'O', 'O', 'O'],
                ['R', 'R', 'Y', 'R', 'R', 'Y', 'R', 'R', 'Y'],
                ['B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B'],
                ['R', 'R', 'R', 'W', 'W', 'W', 'W', 'W', 'W'],
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Back_90_Anti_Clockwise_Successfully()
        {
            _rubikCubeService.RotateBack90AntiClockwise();

            char[][] modifiedFaces =
            [
                ['G', 'G', 'G', 'G', 'G', 'G', 'G', 'G', 'G'],
                ['Y', 'O', 'O', 'Y', 'O', 'O', 'Y', 'O', 'O'],
                ['Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'R', 'R', 'R'],
                ['R', 'R', 'W', 'R', 'R', 'W', 'R', 'R', 'W'],
                ['B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B'],
                ['O', 'O', 'O', 'W', 'W', 'W', 'W', 'W', 'W'],
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Left_90_Clockwise_Successfully()
        {
            _rubikCubeService.RotateLeft90Clockwise();

           char[][] modifiedFaces =
           [
               ['W', 'G', 'G', 'W', 'G', 'G', 'W', 'G', 'G'],
               ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
               ['G', 'Y', 'Y', 'G', 'Y', 'Y', 'G', 'Y', 'Y'],
               ['R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R'],
               ['B', 'B', 'Y', 'B', 'B', 'Y', 'B', 'B', 'Y'],
               ['B', 'W', 'W', 'B', 'W', 'W', 'B', 'W', 'W']
           ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Left_90_Anti_Clockwise_Successfully()
        {
            _rubikCubeService.RotateLeft90AntiClockwise();

            char[][] modifiedFaces =
            [
                ['Y', 'G', 'G', 'Y', 'G', 'G', 'Y', 'G', 'G'],
                ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'],
                ['B', 'Y', 'Y', 'B', 'Y', 'Y', 'B', 'Y', 'Y'],
                ['R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R'],
                ['B', 'B', 'W', 'B', 'B', 'W', 'B', 'B', 'W'],
                ['G', 'W', 'W', 'G', 'W', 'W', 'G', 'W', 'W']
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Down_90_Clockwise_Successfully()
        {
            _rubikCubeService.RotateDown90Clockwise();

            char[][] modifiedFaces =
            [
                ['G', 'G', 'G', 'G', 'G', 'G', 'O', 'O', 'O'],
                ['O', 'O', 'O', 'O', 'O', 'O', 'B', 'B', 'B'],
                ['Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y'],
                ['R', 'R', 'R', 'R', 'R', 'R', 'G', 'G', 'G'],
                ['B', 'B', 'B', 'B', 'B', 'B', 'R', 'R', 'R'],
                ['W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W'],
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }

        [Test]
        public void Rotate_Down_90_Anti_Clockwise_Successfully()
        {
            _rubikCubeService.RotateDown90AntiClockwise();

            char[][] modifiedFaces =
            [
                ['G', 'G', 'G', 'G', 'G', 'G', 'R', 'R', 'R'],
                ['O', 'O', 'O', 'O', 'O', 'O', 'G', 'G', 'G'],
                ['Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y'],
                ['R', 'R', 'R', 'R', 'R', 'R', 'B', 'B', 'B'],
                ['B', 'B', 'B', 'B', 'B', 'B', 'O', 'O', 'O'],
                ['W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W'],
            ];

            Assert.That(_rubikCubeService.GetRubikFaces(), Is.EqualTo(modifiedFaces));
        }
    }
}