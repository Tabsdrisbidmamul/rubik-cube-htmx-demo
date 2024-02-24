using System.Linq;

namespace RubikCube.Services
{
    public class RubkiCubeSerrvice : IRubikCube
    {
        private char[][] _rubikCubeFaces = [
            // Tl    // TR // ML     //MR //BL      //BR   
            ['G', 'G', 'G', 'G', 'G', 'G', 'G', 'G', 'G',], // 0:Front
            ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O',], // 1:Left
            ['Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y',], // 2:Bottom
            ['R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R',], // 3:Right
            ['B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B',], // 4:Back
            ['W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W',], // 5:Top
        ];

        public void reset()
        {
            _rubikCubeFaces = [
            // Tl    // TR // ML     //MR //BL      //BR   
            ['G', 'G', 'G', 'G', 'G', 'G', 'G', 'G', 'G',], // 0:Front
                ['O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O',], // 1:Left
                ['Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y', 'Y',], // 2:Bottom
                ['R', 'R', 'R', 'R', 'R', 'R', 'R', 'R', 'R',], // 3:Right
                ['B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B',], // 4:Back
                ['W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W',], // 5:Top
            ];
        }

        int frontClockwiseRotation = 0;
        int frontAntiClockwiseRotation = 0;
        int backClockwiseRotation = 0;
        int backAntiClockwiseRotation = 0;
        int upClockwiseRotation = 0;
        int upAntiClockwiseRotation = 0;
        int downClockwiseRotation = 0;
        int downAntiClockwiseRotation = 0;
        int rightClockwiseRotation = 0;
        int rightAntiClockwiseRotation = 0;
        int leftClockwiseRotation = 0;
        int leftAntiClockwiseRotation = 0;

        public char[][] getRubikFaces()
        {
            return _rubikCubeFaces;
        }

        public void rotateFront90Clockwise()
        {
            char[] left = [
                _rubikCubeFaces[1][2],
                _rubikCubeFaces[1][5],
                _rubikCubeFaces[1][8]
            ];

            char[] top = [
                _rubikCubeFaces[5][6],
                _rubikCubeFaces[5][7],
                _rubikCubeFaces[5][8]
            ];

            char[] right = [
                _rubikCubeFaces[3][0],
                _rubikCubeFaces[3][3],
                _rubikCubeFaces[3][6]
            ];

            char[] bottom = [
                _rubikCubeFaces[2][0],
                _rubikCubeFaces[2][1],
                _rubikCubeFaces[2][2]
            ];

            // move left to top
            _rubikCubeFaces[5][6] = left[0];
            _rubikCubeFaces[5][7] = left[1];
            _rubikCubeFaces[5][8] = left[2];

            // move top to right
            _rubikCubeFaces[3][0] = top[0];
            _rubikCubeFaces[3][3] = top[1];
            _rubikCubeFaces[3][6] = top[2];

            // move right to bottom
            _rubikCubeFaces[2][0] = right[0];
            _rubikCubeFaces[2][1] = right[1];
            _rubikCubeFaces[2][2] = right[2];

            // move bottom to left
            _rubikCubeFaces[1][2] = bottom[0];
            _rubikCubeFaces[1][5] = bottom[1];
            _rubikCubeFaces[1][8] = bottom[2];
        }

        public void rotateFront90AntiClockwise()
        {
            char[] left = [
                _rubikCubeFaces[1][2],
                _rubikCubeFaces[1][5],
                _rubikCubeFaces[1][8]
            ];

            char[] top = [
                _rubikCubeFaces[5][6],
                _rubikCubeFaces[5][7], 
                _rubikCubeFaces[5][8]
            ];

            char[] right = [
                _rubikCubeFaces[3][0],
                _rubikCubeFaces[3][3],
                _rubikCubeFaces[3][6]
            ];

            char[] bottom = [
                _rubikCubeFaces[2][0],
                _rubikCubeFaces[2][1],
                _rubikCubeFaces[2][2]
            ];

            // move right to top
            _rubikCubeFaces[5][6] = right[0];
            _rubikCubeFaces[5][7] = right[1];
            _rubikCubeFaces[5][8] = right[2];

            // move bottom to right
            _rubikCubeFaces[3][0] = bottom[0];
            _rubikCubeFaces[3][3] = bottom[1];
            _rubikCubeFaces[3][6] = bottom[2];

            // move left to bottom
            _rubikCubeFaces[2][0] = left[0];
            _rubikCubeFaces[2][1] = left[1];
            _rubikCubeFaces[2][2] = left[2];

            // move top to left
            _rubikCubeFaces[1][2] = top[0];
            _rubikCubeFaces[1][5] = top[1];
            _rubikCubeFaces[1][8] = top[2];
        }


        public void rotateBack90Clockwise()
        {
            char[] bottom = [
                _rubikCubeFaces[2][6],
                _rubikCubeFaces[2][7],
                _rubikCubeFaces[2][8]
            ];

            char[] top = [
                _rubikCubeFaces[5][0],
                _rubikCubeFaces[5][1],
                _rubikCubeFaces[5][2]
            ];

            char[] left = [
                _rubikCubeFaces[1][0],
                _rubikCubeFaces[1][3],
                _rubikCubeFaces[1][6]
            ];

            char[] right = [
                _rubikCubeFaces[3][2],
                _rubikCubeFaces[3][5],
                _rubikCubeFaces[3][8]
            ];

            // move bottom to right
            _rubikCubeFaces[3][2] = bottom[0];
            _rubikCubeFaces[3][5] = bottom[1];
            _rubikCubeFaces[3][8] = bottom[2];

            // move right to top
            _rubikCubeFaces[5][0] = right[0];
            _rubikCubeFaces[5][1] = right[1];
            _rubikCubeFaces[5][2] = right[2];

            // move top to left
            _rubikCubeFaces[1][0] = top[0];
            _rubikCubeFaces[1][3] = top[1];
            _rubikCubeFaces[1][6] = top[2];

            // move left to bottom
            _rubikCubeFaces[2][6] = left[0];
            _rubikCubeFaces[2][7] = left[1];
            _rubikCubeFaces[2][8] = left[2];
        }

        public void rotateBack90AntiClockwise()
        {
            char[] bottom = [
                _rubikCubeFaces[2][6],
                _rubikCubeFaces[2][7],
                _rubikCubeFaces[2][8]
            ];

            char[] top = [
                _rubikCubeFaces[5][0],
                _rubikCubeFaces[5][1],
                _rubikCubeFaces[5][2]
            ];

            char[] left = [
                _rubikCubeFaces[1][0],
                _rubikCubeFaces[1][3],
                _rubikCubeFaces[1][6]
            ];

            char[] right = [
                _rubikCubeFaces[3][2],
                _rubikCubeFaces[3][5],
                _rubikCubeFaces[3][8]
            ];

            // move top to right
            _rubikCubeFaces[3][2] = top[0];
            _rubikCubeFaces[3][5] = top[1];
            _rubikCubeFaces[3][8] = top[2];

            // move left to top
            _rubikCubeFaces[5][0] = left[0];
            _rubikCubeFaces[5][1] = left[1];
            _rubikCubeFaces[5][2] = left[2];

            // move bottom to left
            _rubikCubeFaces[1][0] = bottom[0];
            _rubikCubeFaces[1][3] = bottom[1];
            _rubikCubeFaces[1][6] = bottom[2];

            // move right to bottom
            _rubikCubeFaces[2][6] = right[0];
            _rubikCubeFaces[2][7] = right[1];
            _rubikCubeFaces[2][8] = right[2];

        }

        public void rotateUp90Clockwise()
        {
            char[] front = [
                _rubikCubeFaces[0][0],
                _rubikCubeFaces[0][1],
                _rubikCubeFaces[0][2]
            ];

            char[] left = [
                _rubikCubeFaces[1][0],
                _rubikCubeFaces[1][1],
                _rubikCubeFaces[1][2]
            ];

            char[] back = [
                _rubikCubeFaces[4][0],
                _rubikCubeFaces[4][1],
                _rubikCubeFaces[4][2]
            ];

            char[] right = [
                _rubikCubeFaces[3][0],
                _rubikCubeFaces[3][1],
                _rubikCubeFaces[3][2]
            ];

            // move front to left
            _rubikCubeFaces[1][0] = front[0];
            _rubikCubeFaces[1][1] = front[1];
            _rubikCubeFaces[1][2] = front[2];

            // move left to back
            _rubikCubeFaces[4][0] = left[0];
            _rubikCubeFaces[4][1] = left[1];
            _rubikCubeFaces[4][2] = left[2];

            // move back to right
            _rubikCubeFaces[3][0] = back[0];
            _rubikCubeFaces[3][1] = back[1];
            _rubikCubeFaces[3][2] = back[2];

            // move right to front
            _rubikCubeFaces[0][0] = right[0];
            _rubikCubeFaces[0][1] = right[1];
            _rubikCubeFaces[0][2] = right[2];
        }

        public void rotateUp90AntiClockwise()
        {
            char[] front = [
                _rubikCubeFaces[0][0],
                _rubikCubeFaces[0][1],
                _rubikCubeFaces[0][2]
            ];

            char[] left = [
                _rubikCubeFaces[1][0],
                _rubikCubeFaces[1][1],
                _rubikCubeFaces[1][2]
            ];

            char[] back = [
                _rubikCubeFaces[4][0],
                _rubikCubeFaces[4][1], 
                _rubikCubeFaces[4][2]
            ];

            char[] right = [
                _rubikCubeFaces[3][0],
                _rubikCubeFaces[3][1],
                _rubikCubeFaces[3][2]
            ];

            // move back to left
            _rubikCubeFaces[1][0] = back[0];
            _rubikCubeFaces[1][1] = back[1];
            _rubikCubeFaces[1][2] = back[2];

            // move left to frront
            _rubikCubeFaces[0][0] = left[0];
            _rubikCubeFaces[0][1] = left[1];
            _rubikCubeFaces[0][2] = left[2];

            // move front to right
            _rubikCubeFaces[3][0] = front[0];
            _rubikCubeFaces[3][1] = front[1];
            _rubikCubeFaces[3][2] = front[2];

            // move right to back
            _rubikCubeFaces[4][0] = right[0];
            _rubikCubeFaces[4][1] = right[1];
            _rubikCubeFaces[4][2] = right[2];
        }

        public void rotateDown90Clockwise()
        {
            char[] back = [
                _rubikCubeFaces[4][6],
                _rubikCubeFaces[4][7],
                _rubikCubeFaces[4][8]
            ];

            char[] right = [
                _rubikCubeFaces[3][6],
                _rubikCubeFaces[3][7],
                _rubikCubeFaces[3][8]
            ];

            char[] front = [
                _rubikCubeFaces[0][6],
                _rubikCubeFaces[0][7],
                _rubikCubeFaces[0][8],
            ];

            char[] left = [
                _rubikCubeFaces[1][6],
                _rubikCubeFaces[1][7],
                _rubikCubeFaces[1][8],
            ];

            // move back to left
            _rubikCubeFaces[1][6] = back[0];
            _rubikCubeFaces[1][7] = back[1];
            _rubikCubeFaces[1][8] = back[2];

            // move left to front
            _rubikCubeFaces[0][6] = left[0];
            _rubikCubeFaces[0][7] = left[1];
            _rubikCubeFaces[0][8] = left[2];

            // move front to right
            _rubikCubeFaces[3][6] = front[0];
            _rubikCubeFaces[3][7] = front[1];
            _rubikCubeFaces[3][8] = front[2];

            // move right to back
            _rubikCubeFaces[4][6] = right[0];
            _rubikCubeFaces[4][7] = right[1];
            _rubikCubeFaces[4][8] = right[2];
        }

        public void rotateDown90AntiClockwise()
        {
            char[] back = [
                _rubikCubeFaces[4][6],
                _rubikCubeFaces[4][7],
                _rubikCubeFaces[4][8]
            ];

            char[] right = [
                _rubikCubeFaces[3][6],
                _rubikCubeFaces[3][7],
                _rubikCubeFaces[3][8]
            ];

            char[] front = [
                _rubikCubeFaces[0][6],
                _rubikCubeFaces[0][7],
                _rubikCubeFaces[0][8],
            ];

            char[] left = [
                _rubikCubeFaces[1][6],
                _rubikCubeFaces[1][7],
                _rubikCubeFaces[1][8],
            ];

            // move left to back
            _rubikCubeFaces[4][6] = left[0];
            _rubikCubeFaces[4][7] = left[1];
            _rubikCubeFaces[4][8] = left[2];

            // back to right
            _rubikCubeFaces[3][6] = back[0];
            _rubikCubeFaces[3][7] = back[1];
            _rubikCubeFaces[3][8] = back[2];

            // mopve right to front
            _rubikCubeFaces[0][6] = right[0];
            _rubikCubeFaces[0][7] = right[1];
            _rubikCubeFaces[0][8] = right[2];

            // move front to left
            _rubikCubeFaces[1][6] = front[0];
            _rubikCubeFaces[1][7] = front[1];
            _rubikCubeFaces[1][8] = front[2];

        }

        public void rotateRight90Clockwise()
        {
            char[] front = [
                _rubikCubeFaces[0][2],
                _rubikCubeFaces[0][5],
                _rubikCubeFaces[0][8],
            ];

            char[] top = [
                _rubikCubeFaces[5][2],
                _rubikCubeFaces[5][5],
                _rubikCubeFaces[5][8],
            ];

            char[] back = [
                _rubikCubeFaces[4][0],
                _rubikCubeFaces[4][3],
                _rubikCubeFaces[4][6],
            ];

            char[] bottom = [
                _rubikCubeFaces[2][2],
                _rubikCubeFaces[2][5],
                _rubikCubeFaces[2][8],
            ];

            // rotate face
            char[] rightColumn1 = [
                _rubikCubeFaces[3][0],
                _rubikCubeFaces[3][3],
                _rubikCubeFaces[3][6],
            ];

            char[] rightColumn2 = [
                _rubikCubeFaces[3][1],
                _rubikCubeFaces[3][4],
                _rubikCubeFaces[3][7],
            ];

            char[] rightColumn3 = [
                _rubikCubeFaces[3][2],
                _rubikCubeFaces[3][5],
                _rubikCubeFaces[3][8],
            ];

            _rubikCubeFaces[3][0] = rightColumn1[0];
            _rubikCubeFaces[3][1] = rightColumn1[1];
            _rubikCubeFaces[3][2] = rightColumn1[2];

            _rubikCubeFaces[3][3] = rightColumn2[0];
            _rubikCubeFaces[3][4] = rightColumn2[1];
            _rubikCubeFaces[3][5] = rightColumn2[2];

            _rubikCubeFaces[3][6] = rightColumn3[0];
            _rubikCubeFaces[3][7] = rightColumn3[1];
            _rubikCubeFaces[3][8] = rightColumn3[2];

            // move front to top
            _rubikCubeFaces[5][2] = front[0];
            _rubikCubeFaces[5][5] = front[1];
            _rubikCubeFaces[5][8] = front[2];

            // move top to back
            _rubikCubeFaces[4][0] = top[2];
            _rubikCubeFaces[4][3] = top[1];
            _rubikCubeFaces[4][6] = top[0];

            // move back to bottom
            _rubikCubeFaces[2][2] = back[2];
            _rubikCubeFaces[2][5] = back[1];
            _rubikCubeFaces[2][8] = back[0];

            // move bottom to front
            _rubikCubeFaces[0][2] = bottom[0];
            _rubikCubeFaces[0][5] = bottom[1];
            _rubikCubeFaces[0][8] = bottom[2];

        }

        public void rotateRight90AntiClockwise()
        {
            char[] front = [
               _rubikCubeFaces[0][2],
                _rubikCubeFaces[0][5],
                _rubikCubeFaces[0][8],
            ];

            char[] top = [
                _rubikCubeFaces[5][2],
                _rubikCubeFaces[5][5],
                _rubikCubeFaces[5][8],
            ];

            char[] back = [
                _rubikCubeFaces[4][0],
                _rubikCubeFaces[4][3],
                _rubikCubeFaces[4][6],
            ];

            char[] bottom = [
                _rubikCubeFaces[2][2],
                _rubikCubeFaces[2][5],
                _rubikCubeFaces[2][8],
            ];

            // rotate face
            char[] rightColumn1 = [
                _rubikCubeFaces[3][0],
                _rubikCubeFaces[3][3],
                _rubikCubeFaces[3][6],
            ];

            char[] rightColumn2 = [
                _rubikCubeFaces[3][1],
                _rubikCubeFaces[3][4],
                _rubikCubeFaces[3][7],
            ];

            char[] rightColumn3 = [
                _rubikCubeFaces[3][2],
                _rubikCubeFaces[3][5],
                _rubikCubeFaces[3][8],
            ];

            _rubikCubeFaces[3][0] = rightColumn3[0];
            _rubikCubeFaces[3][1] = rightColumn3[1];
            _rubikCubeFaces[3][2] = rightColumn3[2];

            _rubikCubeFaces[3][3] = rightColumn2[0];
            _rubikCubeFaces[3][4] = rightColumn2[1];
            _rubikCubeFaces[3][5] = rightColumn2[2];

            _rubikCubeFaces[3][6] = rightColumn1[0];
            _rubikCubeFaces[3][7] = rightColumn1[1];
            _rubikCubeFaces[3][8] = rightColumn1[2];

            // move back to top
            _rubikCubeFaces[5][2] = back[0];
            _rubikCubeFaces[5][5] = back[1];
            _rubikCubeFaces[5][8] = back[2];

            // move top to front
            _rubikCubeFaces[0][2] = top[0];
            _rubikCubeFaces[0][5] = top[1];
            _rubikCubeFaces[0][8] = top[2];

            // move front to bottom
            _rubikCubeFaces[2][2] = front[0];
            _rubikCubeFaces[2][5] = front[1];
            _rubikCubeFaces[2][8] = front[2];

            // move bottom to back
            _rubikCubeFaces[4][0] = bottom[2];
            _rubikCubeFaces[4][3] = bottom[1];
            _rubikCubeFaces[4][6] = bottom[0];
        }

        public void rotateLeft90Clockwise()
        {
            char[] front = [
                _rubikCubeFaces[0][0],
                _rubikCubeFaces[0][3],
                _rubikCubeFaces[0][6]
            ];

            char[] top = [
                _rubikCubeFaces[5][0],
                _rubikCubeFaces[5][3],
                _rubikCubeFaces[5][6],
            ];

            char[] back = [
                _rubikCubeFaces[4][2],
                _rubikCubeFaces[4][5],
                _rubikCubeFaces[4][8],
            ];

            char[] bottom = [
                _rubikCubeFaces[2][0],
                _rubikCubeFaces[2][3],
                _rubikCubeFaces[2][6],
            ];

            // move top to front
            _rubikCubeFaces[0][0] = top[0];
            _rubikCubeFaces[0][3] = top[1];
            _rubikCubeFaces[0][6] = top[2];

            // move front to bottom
            _rubikCubeFaces[2][0] = front[0];
            _rubikCubeFaces[2][3] = front[1];
            _rubikCubeFaces[2][6] = front[2];

            // move bottom to back
            _rubikCubeFaces[4][2] = bottom[0];
            _rubikCubeFaces[4][5] = bottom[1];
            _rubikCubeFaces[4][8] = bottom[2];

            // move back to top
            _rubikCubeFaces[5][0] = back[0];
            _rubikCubeFaces[5][3] = back[1];
            _rubikCubeFaces[5][6] = back[2];

        }

        public void rotateLeft90AntiClockwise()
        {
            char[] front = [
                _rubikCubeFaces[0][0],
                _rubikCubeFaces[0][3],
                _rubikCubeFaces[0][6]
            ];

            char[] top = [
                _rubikCubeFaces[5][0],
                _rubikCubeFaces[5][3],
                _rubikCubeFaces[5][6],
            ];

            char[] back = [
                _rubikCubeFaces[4][2],
                _rubikCubeFaces[4][5],
                _rubikCubeFaces[4][8],
            ];

            char[] bottom = [
                _rubikCubeFaces[2][0],
                _rubikCubeFaces[2][3],
                _rubikCubeFaces[2][6],
            ];

            // move top to back
            _rubikCubeFaces[4][2] = top[0];
            _rubikCubeFaces[4][5] = top[1];
            _rubikCubeFaces[4][8] = top[2];

            // move back to bottom
            _rubikCubeFaces[2][0] = back[0];
            _rubikCubeFaces[2][3] = back[1];
            _rubikCubeFaces[2][6] = back[2];

            // move bottom to front
            _rubikCubeFaces[0][0] = bottom[0];
            _rubikCubeFaces[0][3] = bottom[1];
            _rubikCubeFaces[0][6] = bottom[2];

            // move front to top
            _rubikCubeFaces[5][0] = front[0];
            _rubikCubeFaces[5][3] = front[1];
            _rubikCubeFaces[5][6] = front[2];

        }
    }
}
