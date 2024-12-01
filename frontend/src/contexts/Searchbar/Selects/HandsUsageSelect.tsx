import React from 'react';
import CustomSelect from '../../../styles/CustomSelect';

interface HandsUsageSelectProps {
  value: string;
  onChange: (value: string | null) => void;
}

const handsusageOptions = [
  { label: 'Super-Sub', value: 'super-sub' },
  { label: 'Mirror', value: 'mirror' },
  { label: 'Async', value: 'async' },
  { label: 'Solo', value: 'solo' },
];

const HandsUsageSelect: React.FC<HandsUsageSelectProps> = ({
  value,
  onChange,
}) => {
  return (
    <CustomSelect
      options={handsusageOptions}
      placeholder="Select Hands Usage"
      value={value}
      onChange={onChange}
    />
  );
};

export default HandsUsageSelect;
