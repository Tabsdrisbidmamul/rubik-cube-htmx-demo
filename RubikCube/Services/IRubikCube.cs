namespace RubikCube.Services
{
    public interface IRubikCube
    {
        char[][] getRubikFaces();
        void reset();
        void rotateFront90Clockwise();
        void rotateFront90AntiClockwise();
        void rotateBack90Clockwise();
        void rotateBack90AntiClockwise();
        void rotateUp90Clockwise();
        void rotateUp90AntiClockwise();
        void rotateDown90Clockwise();
        void rotateDown90AntiClockwise();
        void rotateRight90Clockwise();
        void rotateRight90AntiClockwise();
        
        
    }
}
