
public abstract class SingletonBase<T>
    where T : SingletonBase<T>
{
    //1
    //2
    private static T m_Instance = null;
    //3
   public static T instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = null;//new T();  //???? 反射技术
            }
            return m_Instance;
        }
    }
  
}

class Student : SingletonBase<Student>
{
    private Student()
    { }
    //字段
    //方法
}