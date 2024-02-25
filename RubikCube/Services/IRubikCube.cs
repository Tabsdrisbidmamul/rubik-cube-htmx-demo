namespace RubikCube.Services
{
    public interface IRubikCube
    {
        char[][] GetRubikFaces();
        void Reset();
        void RotateFront90Clockwise();
        void RotateFront90AntiClockwise();
        void RotateBack90Clockwise();
        void RotateBack90AntiClockwise();
        void RotateUp90Clockwise();
        void RotateUp90AntiClockwise();
        void RotateDown90Clockwise();
        void RotateDown90AntiClockwise();
        void RotateRight90Clockwise();
        void RotateRight90AntiClockwise();
        void RotateLeft90Clockwise();
        void RotateLeft90AntiClockwise();
        
        
    }
}
