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

            char[] right = [_rubikCubeFaces[3][6],]
        }

        public void rotateDown90AntiClockwise()
        {
            throw new NotImplementedException();
        }

        public void rotateRight90Clockwise()
        {
            throw new NotImplementedException();
        }

        public void rotateRight90AntiClockwise()
        {
            throw new NotImplementedException();
        }


    }
}
