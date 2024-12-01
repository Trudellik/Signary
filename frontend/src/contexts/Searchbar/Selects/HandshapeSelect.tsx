import React from 'react';
import bIcon from '../../../assets/handshape-icons/b-haand.png';
import flyIcon from '../../../assets/handshape-icons/fly-haand.png';
import pegeIcon from '../../../assets/handshape-icons/pege-haand.png';
import CustomSelect from '../../../styles/CustomSelect';

interface HandshapeSelectProps {
  value: string;
  onChange: (value: string | null) => void;
}

const options = [
  {
    label: (
      <img
        src={bIcon}
        alt="B"
        style={{ width: '30px', height: '30px', objectFit: 'contain' }}
      />
    ),
    value: 'b',
  },
  {
    label: (
      <img
        src={flyIcon}
        alt="Fly"
        style={{ width: '30px', height: '30px', objectFit: 'contain' }}
      />
    ),
    value: 'fly',
  },
  {
    label: (
      <img
        src={pegeIcon}
        alt="Pege"
        style={{ width: '30px', height: '30px', objectFit: 'contain' }}
      />
    ),
    value: 'pege',
  },
];

const HandshapeSelect: React.FC<HandshapeSelectProps> = ({
  value,
  onChange,
}) => {
  return (
    <CustomSelect
      options={options}
      placeholder="Select Handshape"
      value={value}
      onChange={onChange}
    />
  );
};

export default HandshapeSelect;
