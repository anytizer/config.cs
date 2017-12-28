using configs.classes.structures;

namespace configs.classes.interfacing
{
    public abstract class config_api : iconfigwriter
    {
        public abstract structure_api read();
        public abstract bool write(structure_api s);
    }
}
