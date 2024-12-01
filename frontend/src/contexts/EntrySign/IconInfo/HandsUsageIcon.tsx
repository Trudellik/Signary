import React, { useEffect, useState } from 'react';
import './IconInfo.css';
import { HandsUsageTypes } from '../../../models/Types';

interface HandsUsageProps {
  handsUsage: HandsUsageTypes;
}

const HandsUsageIcon = ({ handsUsage }: HandsUsageProps) => {
  // State to hold the resolved image path
  const [handUsageImagePath, setHandUsageImagePath] = useState<string | null>(
    null
  );

  useEffect(() => {
    const loadImage = async () => {
      try {
        // Dynamically import the image
        const imageModule = await import(
          `../../../assets/handusage-icons/${handsUsage}.png`
        );
        setHandUsageImagePath(imageModule.default);
      } catch (error) {
        // If the image doesn't exist, set it to null
        console.error('Image not found', error);
        setHandUsageImagePath(null);
      }
    };

    if (handsUsage) {
      loadImage();
    }
  }, [handsUsage]);

  return (
    <div className="facts">
      {handUsageImagePath ? (
        <img
          src={handUsageImagePath}
          alt={`${handsUsage} handshape`}
          className="handshape-image"
        />
      ) : (
        <div className="handshape-placeholder">{handsUsage}</div>
      )}
    </div>
  );
};

export default HandsUsageIcon;
