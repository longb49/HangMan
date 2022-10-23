class IsOver
{
    public bool isDead(int health)
    {
        if (health == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isFinished(List<string> unArray)
    {
        List<int> idx = new List<int>{};
        idx.Add(unArray.IndexOf("_"));
        if (idx.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}