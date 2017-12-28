using configs.classes.structures;

namespace configs.classes.interfacing
{
    public abstract class config_software : iconfigwriter
    {
        public abstract structure_software read();
        public abstract bool write(structure_software s);
    }
}
