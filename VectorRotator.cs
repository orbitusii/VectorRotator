public static class VectorRotator {
    public static Vector3 RotateVector(Vector3 vector, Vector3 euler)
    {
        float X = vector.x;
        float Y = vector.y;
        float Z = vector.z;

        //Do rotations around Zfirst (like Unity does) - ROLL
        float A = euler.z * Mathf.Deg2Rad;
        //Then around X (like Unity) - PITCH
        float B = euler.x * Mathf.Deg2Rad;
        //Then around Y (like Unity) - YAW
        float C = euler.y * Mathf.Deg2Rad;

        //Get our Sine and Cosine values stored for potential debugging and easy access
        float cosA = Mathf.Cos(A);
        float sinA = Mathf.Sin(A);

        float cosB = Mathf.Cos(B);
        float sinB = Mathf.Sin(B);

        float cosC = Mathf.Cos(C);
        float sinC = Mathf.Sin(C);

        //Perform the rotations, or rather, calculate the values of each axis after rotating (same thing, right?)
        float fX =
            X * (cosA * cosC + sinA * sinB * sinC) +
            Y * (cosA * sinB * sinC - sinA * cosC) +
            Z * cosB * sinC;

        float fY =
            X * (sinA * cosB) +
            Y * (cosA * cosB) -
            Z * sinB;

        float fZ =
            X * (sinA * sinB * cosC - cosA * sinC) +
            Y * (sinA * sinC + cosA * sinB * cosC) +
            Z * (cosB * cosC);

        return new Vector3(fX, fY, fZ);
    }
}