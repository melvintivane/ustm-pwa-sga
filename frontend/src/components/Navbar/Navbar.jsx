import "./Navbar.css";

const Header = () => {
  return (
    <>
      <div className="nav__container">
        <div className="nav__left">
          <p className="logo">Krupp</p>
        </div>
        <div className="nav__center">
          <li className="active">Inicio</li>
          <li className="">Notas</li>
          <li className="">Exames</li>
          <li className="">Mensagens</li>
        </div>
        <div className="nav__right">
          <button className="button">Login</button>
        </div>
      </div>
      <hr className="hr"/>
    </>
  );
};

export default Header;
