using System.Linq;

namespace RubikCube.Services
{

    enum Face 
    {
        Front = 0,
        Back = 4, 
        Top = 5, 
        Bottom = 2,
        Right = 3, 
        Left = 1,
    }

    public class RubkiCubeSerrvice : IRubikCube
    {
        int frontRotation = 0;
        int backRotation = 0;
        int upRotation = 0;
        int downRotation = 0;
        int rightRotation = 0;
        int leftRotation = 0;

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

            frontRotation = 0;
            backRotation = 0;
            upRotation = 0;
            downRotation = 0;
            rightRotation = 0;
            leftRotation = 0;
        }



        public char[][] getRubikFaces()
        {
            return _rubikCubeFaces;
        }

        public void rotateFront90Clockwise()
        {
            if(frontRotation == 360)
            {
                frontRotation = 0;
            } 
            else
            {
                frontRotation += 90;
            }

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

            rotateFace(Face.Front, frontRotation);

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
            if (frontRotation == -360)
            {
                frontRotation = 0;
            }
            else
            {
                frontRotation -= 90;
            }

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

            rotateFace(Face.Front, frontRotation);

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
            if (backRotation == 360)
            {
                backRotation = 0;
            }
            else
            {
                backRotation += 90;
            }

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

            rotateFace(Face.Back, backRotation);

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
            if (backRotation == -360)
            {
                backRotation = 0;
            }
            else
            {
                backRotation -= 90;
            }

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

            rotateFace(Face.Back, backRotation);

            // move top to right
            _rubikCubeFaces[3][2] = top[0];
            _rubikCubeFaces[3][5] = top[1];
            _rubikCubeFaces[3][8] = top[2];

            // move left to top
            _rubikCubeFaces[5][0] = left[2];
            _rubikCubeFaces[5][1] = left[1];
            _rubikCubeFaces[5][2] = left[0];

            // move bottom to left
            _rubikCubeFaces[1][0] = bottom[0];
            _rubikCubeFaces[1][3] = bottom[1];
            _rubikCubeFaces[1][6] = bottom[2];

            // move right to bottom
            _rubikCubeFaces[2][6] = right[2];
            _rubikCubeFaces[2][7] = right[1];
            _rubikCubeFaces[2][8] = right[0];

        }

        public void rotateUp90Clockwise()
        {
            if (upRotation == 360)
            {
                upRotation = 0;
            }
            else
            {
                upRotation += 90;
            }

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

            rotateFace(Face.Top, upRotation);

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
            if (upRotation == -360)
            {
                upRotation = 0;
            }
            else
            {
                upRotation -= 90;
            }

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

            rotateFace(Face.Top, upRotation);

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
            if (downRotation == 360)
            {
                downRotation = 0;
            }
            else
            {
                downRotation += 90;
            }

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

            rotateFace(Face.Bottom, downRotation);

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
            if (downRotation == -360)
            {
                downRotation = 0;
            }
            else
            {
                downRotation -= 90;
            }

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

            rotateFace(Face.Bottom, downRotation);

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
            if (rightRotation == 360)
            {
                rightRotation = 0;
            }
            else
            {
                rightRotation += 90;
            }

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

            rotateFace(Face.Right, rightRotation);

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
            if(rightRotation == -360)
            {
                rightRotation = 0;
            }
            else
            {
                rightRotation -= 90;
            }

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

            rotateFace(Face.Right, rightRotation);

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
            if (leftRotation == 360)
            {
                leftRotation = 0;
            }
            else
            {
                leftRotation += 90;
            }

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

            rotateFace(Face.Left, leftRotation);

            // move top to front
            _rubikCubeFaces[0][0] = top[0];
            _rubikCubeFaces[0][3] = top[1];
            _rubikCubeFaces[0][6] = top[2];

            // move front to bottom
            _rubikCubeFaces[2][0] = front[0];
            _rubikCubeFaces[2][3] = front[1];
            _rubikCubeFaces[2][6] = front[2];

            // move bottom to back
            _rubikCubeFaces[4][2] = bottom[2];
            _rubikCubeFaces[4][5] = bottom[1];
            _rubikCubeFaces[4][8] = bottom[0];

            // move back to top
            _rubikCubeFaces[5][0] = back[2];
            _rubikCubeFaces[5][3] = back[1];
            _rubikCubeFaces[5][6] = back[0];

        }

        public void rotateLeft90AntiClockwise()
        {
            if (leftRotation == -360)
            {
                leftRotation = 0;
            }
            else
            {
                leftRotation -= 90;
            }

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

            rotateFace(Face.Left, leftRotation);

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

        private void rotateFace(Face face, int rotation) 
        {
            int faceValue = (int)face;

            switch (rotation) 
            {
                case 0:
                case 90:
                case 270:
                    {
                        char[] faceColumn1 = [
                            _rubikCubeFaces[faceValue][0],
                            _rubikCubeFaces[faceValue][3],
                            _rubikCubeFaces[faceValue][6],
                        ];

                        char[] faceColumn2 = [
                            _rubikCubeFaces[faceValue][1],
                            _rubikCubeFaces[faceValue][4],
                            _rubikCubeFaces[faceValue][7],
                        ];

                        char[] faceColumn3 = [
                            _rubikCubeFaces[faceValue][2],
                            _rubikCubeFaces[faceValue][5],
                            _rubikCubeFaces[faceValue][8],
                        ];

                        _rubikCubeFaces[faceValue][0] = faceColumn1[2];
                        _rubikCubeFaces[faceValue][1] = faceColumn1[1];
                        _rubikCubeFaces[faceValue][2] = faceColumn1[0];

                        _rubikCubeFaces[faceValue][3] = faceColumn2[2];
                        _rubikCubeFaces[faceValue][4] = faceColumn2[1];
                        _rubikCubeFaces[faceValue][5] = faceColumn2[0];

                        _rubikCubeFaces[faceValue][6] = faceColumn3[2];
                        _rubikCubeFaces[faceValue][7] = faceColumn3[1];
                        _rubikCubeFaces[faceValue][8] = faceColumn3[0];

                        break;
                    }
                
                case 180:
                case 360:
                    {
                        char[] faceRow1 = [
                           _rubikCubeFaces[faceValue][0],
                            _rubikCubeFaces[faceValue][1],
                            _rubikCubeFaces[faceValue][2],
                        ];

                        char[] faceRow2 = [
                            _rubikCubeFaces[faceValue][3],
                            _rubikCubeFaces[faceValue][4],
                            _rubikCubeFaces[faceValue][5],
                        ];

                        char[] faceRow3 = [
                            _rubikCubeFaces[faceValue][6],
                            _rubikCubeFaces[faceValue][7],
                            _rubikCubeFaces[faceValue][8],
                        ];

                        _rubikCubeFaces[faceValue][0] = faceRow3[0];
                        _rubikCubeFaces[faceValue][3] = faceRow3[1];
                        _rubikCubeFaces[faceValue][6] = faceRow3[2];

                        _rubikCubeFaces[faceValue][1] = faceRow2[0];
                        _rubikCubeFaces[faceValue][4] = faceRow2[1];
                        _rubikCubeFaces[faceValue][7] = faceRow2[2];

                        _rubikCubeFaces[faceValue][2] = faceRow1[0];
                        _rubikCubeFaces[faceValue][5] = faceRow1[1];
                        _rubikCubeFaces[faceValue][8] = faceRow1[2];

                        break;
                    }


                case -90: 
                case -270:
                    {
                        char[] faceColumn1 = [
                            _rubikCubeFaces[faceValue][0],
                            _rubikCubeFaces[faceValue][3],
                            _rubikCubeFaces[faceValue][6],
                        ];

                        char[] faceColumn2 = [
                            _rubikCubeFaces[faceValue][1],
                            _rubikCubeFaces[faceValue][4],
                            _rubikCubeFaces[faceValue][7],
                        ];

                        char[] faceColumn3 = [
                            _rubikCubeFaces[faceValue][2],
                            _rubikCubeFaces[faceValue][5],
                            _rubikCubeFaces[faceValue][8],
                        ];

                        _rubikCubeFaces[faceValue][0] = faceColumn3[0];
                        _rubikCubeFaces[faceValue][1] = faceColumn3[1];
                        _rubikCubeFaces[faceValue][2] = faceColumn3[2];

                        _rubikCubeFaces[faceValue][3] = faceColumn2[0];
                        _rubikCubeFaces[faceValue][4] = faceColumn2[1];
                        _rubikCubeFaces[faceValue][5] = faceColumn2[2];

                        _rubikCubeFaces[faceValue][6] = faceColumn1[0];
                        _rubikCubeFaces[faceValue][7] = faceColumn1[1];
                        _rubikCubeFaces[faceValue][8] = faceColumn1[2];


                        break;
                    
                    }

                case -180:
                case -360:
                    {
                        char[] faceRow1 = [
                          _rubikCubeFaces[faceValue][0],
                            _rubikCubeFaces[faceValue][1],
                            _rubikCubeFaces[faceValue][2],
                        ];

                        char[] faceRow2 = [
                            _rubikCubeFaces[faceValue][3],
                            _rubikCubeFaces[faceValue][4],
                            _rubikCubeFaces[faceValue][5],
                        ];

                        char[] faceRow3 = [
                            _rubikCubeFaces[faceValue][6],
                            _rubikCubeFaces[faceValue][7],
                            _rubikCubeFaces[faceValue][8],
                        ];

                        _rubikCubeFaces[faceValue][0] = faceRow1[0];
                        _rubikCubeFaces[faceValue][3] = faceRow1[1];
                        _rubikCubeFaces[faceValue][6] = faceRow1[2];

                        _rubikCubeFaces[faceValue][1] = faceRow2[0];
                        _rubikCubeFaces[faceValue][4] = faceRow2[1];
                        _rubikCubeFaces[faceValue][7] = faceRow2[2];

                        _rubikCubeFaces[faceValue][2] = faceRow3[0];
                        _rubikCubeFaces[faceValue][5] = faceRow3[1];
                        _rubikCubeFaces[faceValue][8] = faceRow3[2];

                        break; 
                    }

            }
        }

    }
}
