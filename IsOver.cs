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
        int check = 0;
        foreach (string i in unArray)
        {
            if (i == "_")
            {
                check++;
            }
            else
            {
                continue;
            }
        }
        if (check == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}