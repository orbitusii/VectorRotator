public static class VectorRotator {
    public static Vector3 RotateVector (Vector3 vector, Vector3 euler)
    {
        Matrix4x4 m = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(euler), Vector3.one);
        Vector3 mForward = m.MultiplyVector(Vector3.forward);
        Vector3 mRight = m.MultiplyVector(Vector3.right);
        Vector3 mUp = m.MultiplyVector(Vector3.up);

        Vector3 dotted = new Vector3(
            Vector3.Dot(vector, mRight),
            Vector3.Dot(vector, mUp),
            Vector3.Dot(vector, mForward)
        );

        return dotted;
    }
}