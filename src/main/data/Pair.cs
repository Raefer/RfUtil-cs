namespace RfUtil_cs.Data
{
    class Pair<F, S>
    {
        private F first;
        private S second;

        public Pair(F first, S second)
        {
            this.first = first;
            this.second = second;
        }

        public void SetFirst(F first)
        {
            this.first = first;
        }

        public F First()
        {
            return first;
        }

        public void SetSecond(S second)
        {
            this.second = second;
        }

        public S Second()
        {
            return second;
        }
    }
}