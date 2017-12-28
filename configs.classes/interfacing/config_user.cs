using configs.classes.structures;

namespace configs.classes.interfacing
{
    public abstract class config_user : iconfigwriter
    {
        public abstract structure_user read();
        public abstract bool write(structure_user s);
    }
}
